# Base image for production
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Render injection port — we must listen on all interfaces
ENV ASPNETCORE_URLS=http://0.0.0.0:${PORT}

EXPOSE 8080

# Build image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["API-Restful/API-Restful.csproj", "API-Restful/"]
RUN dotnet restore "API-Restful/API-Restful.csproj"

COPY . .
WORKDIR "/src/API-Restful"
RUN dotnet build "API-Restful.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish image
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "API-Restful.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "API_Restful.dll"]
