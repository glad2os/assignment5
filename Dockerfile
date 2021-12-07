FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["assignment5.csproj", "./"]
RUN dotnet restore "assignment5.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "assignment5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "assignment5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "assignment5.dll"]
