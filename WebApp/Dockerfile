FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build

WORKDIR /src
COPY .  .
RUN dotnet publish -c Release -o out "WebApp.csproj"


FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine
EXPOSE 80
WORKDIR /app
COPY --from=build /src/out .

ENTRYPOINT [ "dotnet", "WebApp.dll" ]