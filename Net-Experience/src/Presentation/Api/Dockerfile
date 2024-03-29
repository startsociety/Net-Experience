#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/Presentation/Api/Net-Experience.csproj", "src/Presentation/Api/"]
COPY ["src/Infrastructure/Configuration/Net.Experience.Configuration.csproj", "src/Infrastructure/Configuration/"]
COPY ["src/Core/Application/Net.Experience.Application.csproj", "src/Core/Application/"]
COPY ["src/Core/Domain/Net.Experience.Domain.csproj", "src/Core/Domain/"]
COPY ["src/Infrastructure/Helpers/Net.Experience.Common.Helpers.csproj", "src/Infrastructure/Helpers/"]
COPY ["src/Infrastructure/Persistance/Net.Experience.Persistance.csproj", "src/Infrastructure/Persistance/"]
RUN dotnet restore "src/Presentation/Api/Net-Experience.csproj"
COPY . .
WORKDIR "/src/src/Presentation/Api"
RUN dotnet build "Net-Experience.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Net-Experience.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Net-Experience.dll"]
