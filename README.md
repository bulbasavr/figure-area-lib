# figure-area-lib
test task

Библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.


# SQL запрос

Создание таблиц

    CREATE TABLE [dbo].[Product] (
        [Id]       INT            PRIMARY KEY NOT NULL,
        [ProductName] NVARCHAR (50) NOT NULL,
    );

    CREATE TABLE [dbo].[Category] (
        [Id]       INT            PRIMARY KEY NOT NULL,
        [CategoryName] NVARCHAR (50) NOT NULL,
    );

    INSERT INTO Product (Id, ProductName) VALUES (1, N'Черешня'), (2, N'Груши'), (3, N'Киви'), (4, N'Томаты')
    INSERT INTO Category (Id, CategoryName) VALUES (1, N'Ягоды'), (2, N'Фрукты'), (3, N'Овощи'), (4, N'Крупы')

    CREATE TABLE [dbo].[ProductCategory] (
        ProductId INT FOREIGN KEY REFERENCES Product(Id),
        CategoryId INT FOREIGN KEY REFERENCES Category(Id),
        PRIMARY KEY (ProductId, CategoryId)
    );

    INSERT INTO ProductCategory VALUES (1, 1), (2, 2), (4, 1), (4, 3)
    
 Вывод данных 
 
    SELECT P."ProductName", C."CategoryName" FROM Product P
    LEFT JOIN ProductCategory PC ON P.Id = PC.ProductId
    LEFT JOIN Category C ON PC.CategoryId = C.Id
