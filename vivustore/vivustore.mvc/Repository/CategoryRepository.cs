using System;
using vivustore.mvc.Data;
using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public class CategoryRepository(ViVuStoreDbContext context) : GenericRepository<Category>(context)
{
}
