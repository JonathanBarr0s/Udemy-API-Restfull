# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o csproj correto (que está na raiz da pasta API-Restful)
COPY ["API-Restful.csproj", "./"]

RUN dotnet restore "API-Restful.csproj"

# Copia todo o restante do projeto
COPY . .

RUN dotnet publish "API-Restful.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "API-Restful.dll"]
