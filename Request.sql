-- В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, 
-- в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
-- Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT p.Name ProductName, c.Name CategoryName
FROM products p
LEFT JOIN ProductCategoryRelations pcr ON p.Id = pcr.ProductId
LEFT JOIN Categories c ON c.Id = pcr.CategoryId