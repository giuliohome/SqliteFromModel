open System
open System.Data

open LinqToDB
open LinqToDB.Data
open LinqToDB.Mapping  

open ClaimStatusModel
open LinqToDB.DataProvider.SQLite


let BuildTable<'T> (schema :SchemaProvider.DatabaseSchema) (db : DataConnection) =
    let tableName = db.MappingSchema.GetEntityDescriptor(typeof<'T>).TableName
    if schema.Tables.Exists(fun t -> t.TypeName.Contains(tableName))
        then  db.DropTable<'T>() 
    let tab = db.CreateTable<'T>()
    Console.WriteLine tab.SqlText 
    Console.ReadLine() |> ignore

[<EntryPoint>]
let main argv = 
    let connString = @"Data Source=\\\\server\\path\\DB\\emptydb"
    let provider = SQLiteDataProvider()
    use db = new DataConnection( provider, connString )
    let schema = provider.GetSchemaProvider().GetSchema(db)
    BuildTable<ClaimModel> schema db 
    BuildTable<Selection> schema db
    0 



