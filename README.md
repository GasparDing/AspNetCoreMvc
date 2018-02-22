# ASP.NET Core MVC and Entity Framework Core
在Visual Studio 的環境下使用 ASP.NET Core MVC 以及 Entity Framework Core 的入門官方教學專案
Getting started with ASP.NET Core MVC and Entity Framework Core using Visual Studio .

開發工具 (IDE)：Visual Studio 2017
框架 (Framework)：.Net Core 2.0

# Conventions 慣例 / 公約

因為有 Conventions 或 Entity Framework 的 假設，我們可以寫少少的Code，讓 Entity Framework 可以幫我們自動建立完整的Database，而這些慣例/公約如以下四點：
The amount of code you had to write in order for the Entity Framework to be able to create a complete database for you is minimal because of the use of conventions, or assumptions that the Entity Framework makes.

1. 宣告為 DbSet屬性的 entity 以名稱，反之則以 class 名稱 作為資料表的命名。
The names of DbSet properties are used as table names. For entities not referenced by a DbSet property, entity class names are used as table names.
2. 每個 Entity 的屬性名稱由欄位名稱決定 (也就是你 models 內宣告的各個名稱)
Entity property names are used for column names.
3. 名為 "ID" 或 "ClassnameID" 會被自動視為 PrimaryKey
Entity properties that are named ID or classnameID are recognized as primary key properties.
4. 若已命名 "ID" 為P.Key，則命名為 "ClassnameID" 的屬性會被當作 ForeignKey，ForeignKey也可以簡寫成 "ClassID"，在 "Enrollment.cs" 中有提到詳細命名規則。
A property has named as ID and P.Key in the original entity is interpreted as a foreign key property in other entity if it's named "ClassID". Foreign key properties can also be named simply.More detail please reference to "Enrollment.cs".