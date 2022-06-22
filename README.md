Para agregar una referencia de proyecto en cli
dotnet add ZipCode.RepositoryEfMySql.csproj  reference ../ZipCode.Core/ZipCode.Core.csproj

EntityFramework
https://jasonwatmore.com/post/2022/03/25/net-6-connect-to-mysql-database-with-entity-framework-core

https://www.entityframeworktutorial.net/efcore/cli-commands-for-ef-core-migration.aspx

Enables these commonly used dotnet-ef commands:
dotnet ef migrations add
dotnet ef migrations list
dotnet ef migrations script
dotnet ef dbcontext info
dotnet ef dbcontext scaffold
dotnet ef database drop
dotnet ef database update

https://docs.microsoft.com/en-us/dotnet/core/tools/

dotnet add package SpreadsheetLight --version 3.5.0
dotnet add package DocumentFormat.OpenXml.DotNet.Core --version 1.0.1

https://www.srcodigofuente.es/sql-actualizar-registros-de-una-tabla-a-otra

https://www.campusmvp.es/recursos/post/visual-studio-code-como-preparar-un-entorno-de-trabajo-para-net-core.aspx


Para la capa de prueba de mongoDB

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-6.0&tabs=visual-studio-code

dotnet add package MongoDB.Driver


var coll = db.GetCollection<BsonDocument>("coll");

var filter = Builders<BsonDocument>.Filter.Eq("Parameters.Value", 11111);
var query = coll.Find(filter);

https://www.mongodb.com/blog/post/quick-start-c-and-mongodb-read-operations

https://digitteck.com/mongo-csharp/filters-in-mongo-csharp/

https://stackoverflow.com/questions/50904811/mongodb-c-sharp-filter-and-get-all-subdocuments

https://gist.github.com/a3dho3yn/91dcc7e6f606eaefaf045fc193d3dcc3

