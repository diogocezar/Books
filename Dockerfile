FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY . /app
RUN dotnet restore
RUN dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY --from=build-env /app/out .
EXPOSE 5000
ENTRYPOINT ["dotnet", "Books.Api.dll"]
