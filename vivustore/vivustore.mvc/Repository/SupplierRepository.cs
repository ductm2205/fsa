using System;
using vivustore.mvc.Data;
using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public class SupplierRepository(ViVuStoreDbContext context) : GenericRepository<Supplier>(context)
{
}
