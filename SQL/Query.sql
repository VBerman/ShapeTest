Select Pr.Name, Ca.Name
From Product Pr
Left Join CategoryProduct CP
On CP.ProductId = Pr.Id
Left Join Category Ca
On CP.CategoryId = Ca.Id