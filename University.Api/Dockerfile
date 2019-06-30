FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["University.Api/University.Api.csproj", "University.Api/"]
COPY ["University.Api.Models/University.Api.Models.csproj", "University.Api.Models/"]
COPY ["University.DAL/University.DAL.csproj", "University.DAL/"]
RUN dotnet restore "University.Api/University.Api.csproj"
COPY . .
WORKDIR "/src/University.Api"
RUN dotnet build "University.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "University.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "University.Api.dll"]