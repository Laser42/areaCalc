/*SQL*/

CREATE TABLE [dbo].[PRODUCTS] (
       [PRODUCT_ID] int IDENTITY(1,1) NOT NULL,
       [NAME] nvarchar(255),
       PRIMARY KEY CLUSTERED ([PRODUCT_ID])
);

CREATE TABLE [dbo].[CATEGORIES] (
       [CATEGORY_ID] int IDENTITY(1,1) NOT NULL,
       [NAME] nvarchar(255),
       PRIMARY KEY CLUSTERED ([CATEGORY_ID])
);

CREATE TABLE [dbo].[CATEGORY_PRODUCT] (
       [CATEGORY_ID] int NOT NULL,
       [PRODUCT_ID] int NOT NULL
);

INSERT INTO [dbo].[PRODUCTS] ([NAME])
    VALUES ('Кроссовки'),('Ботинки'),('Мяч'),('Плеер');
    --ID: 1,2,3,4
    
INSERT INTO [dbo].[CATEGORIES] ([NAME])
    VALUES ('Обувь'),('Спорт');
    --ID: 1,2

INSERT INTO [dbo].[CATEGORY_PRODUCT]
    VALUES (1,1) --Кроссовки, Обувь
        ,(1,2) --Кроссовки, Спорт
        ,(2,1) --Ботинки, Обувь
        ,(3,2) --Мяч, Спорт
        ;
--Плеер не определен ни в одну из категорий

SELECT
    [P].[NAME] as [PRODUCT_NAME]
    ,ISNULL([C].[NAME],'<нет категорий>') as [CATEGORY_NAME]
    FROM [dbo].[PRODUCTS] as [P]
        LEFT JOIN [dbo].[CATEGORY_PRODUCT] as [CP]
            ON [CP].[PRODUCT_ID] = [P].[PRODUCT_ID]
        LEFT JOIN [dbo].[CATEGORIES] as [C]
            ON [C].[CATEGORY_ID] = [CP].[CATEGORY_ID]
