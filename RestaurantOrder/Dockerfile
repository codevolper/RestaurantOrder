# Stage 1: Base Application Image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Stage 2: Build application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RestaurantOrder/RestaurantOrderRouting.Api.csproj", "RestaurantOrder/"]
RUN dotnet restore "./RestaurantOrder/./RestaurantOrderRouting.Api.csproj"
COPY . .
WORKDIR "/src/RestaurantOrder"
RUN dotnet build "./RestaurantOrderRouting.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Stage 3: Publishing the application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./RestaurantOrderRouting.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Stage 4: Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RestaurantOrder.dll"]