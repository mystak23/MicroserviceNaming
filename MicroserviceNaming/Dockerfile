FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MicroserviceNaming/MicroserviceNaming.csproj", "MicroserviceNaming/"]
RUN dotnet restore "MicroserviceNaming/MicroserviceNaming.csproj"
COPY . .
WORKDIR "/src/MicroserviceNaming"
RUN dotnet build "MicroserviceNaming.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroserviceNaming.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroserviceNaming.dll"]
