# .Net Core Generic Repository Pattern with Dapper and Unit Of Work 
Dapper Generic Repository Pattern With .Net Core

In this repo, we will implement simple and clean Generic Repository Architecture. We will also try to implement unit of work as well!

Everything put together, this repository helps you to understand How Dapper can be used in an ASP.NET Core Application following Repostitory Pattern and Unit of Work. 

Here is the source code of the entire implementation. Let’s get started.

## What is Dapper?

Dapper is a simple Object Mapping Framework or a Micro-ORM that helps us to Map the Data from the Result of an SQL Query to a .NET Class effeciently. It would be as simple as executing a SQL Select Statement using the SQL Client object and returning the result as a Mapped Domain C# Class. It’s more like an Automapper for the SQL World. This powerful ORM was build by the folks at StackOverflow and is definitely faster at querying data when compared to the performance of Entity Framework. This is possible because Dapper works directly with the RAW SQL and hence the time-delay is quite less. This boosts the performance of Dapper.

## Build & Run

First Create a MSSQL Database and Create a table with name 'Products' as below:

```sql
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Barcode] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Rate] [decimal](18, 2) NOT NULL,
	[AddedOn] [datetime] NOT NULL,
	[ModifiedOn] [datetime] NULL,
  [CategoryID] [int] NOT NULL
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```

Modify your connection string under **appsettings.json** file with your connection information. 

And then, build & run project. Default page will be **swagger ui**. You can easily test your endpoints.

Thanks for reading!
