SELECT products.name AS NameOfProduct, categories.name AS CategoryOfProduct
FROM dbo.products AS products
LEFT JOIN dbo.products_map ON products.id = products_map.product_id
LEFT JOIN dbo.categories AS categories ON products_map.category_id = categories.id


