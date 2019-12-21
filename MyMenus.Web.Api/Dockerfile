#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MyMenus.Web.Api/MyMenus.Web.Api.csproj", "MyMenus.Web.Api/"]
RUN dotnet restore "MyMenus.Web.Api/MyMenus.Web.Api.csproj"
COPY . .
WORKDIR "/src/MyMenus.Web.Api"
RUN dotnet build "MyMenus.Web.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyMenus.Web.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyMenus.Web.Api.dll"]