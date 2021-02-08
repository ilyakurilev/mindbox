SELECT P.[Name] AS 'Product',
       C.[Name] AS 'Category'
  FROM [Products] AS P
  LEFT JOIN [ProductsCategories] AS PC
    ON P.Id = PC.ProductId
  LEFT JOIN [Categories] AS C
    ON C.Id = PC.CategoryId;
