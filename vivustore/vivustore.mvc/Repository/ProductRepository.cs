using System;
using vivustore.mvc.Data;
using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public class ProductRepository(ViVuStoreDbContext context) : GenericRepository<Product>(context)
{
}
