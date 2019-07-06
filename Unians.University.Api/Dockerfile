FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Unians.University.Api/Unians.University.Api.csproj", "Unians.University.Api/"]
COPY ["Unians.University.Api.Data/Unians.University.Api.Data.csproj", "Unians.University.Api.Data/"]
COPY ["Unians.University.Data/Unians.University.Data.csproj", "Unians.University.Data/"]
RUN dotnet restore "Unians.University.Api/Unians.University.Api.csproj"
COPY . .
WORKDIR "/src/Unians.University.Api"
RUN dotnet build "Unians.University.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Unians.University.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Unians.University.Api.dll"]