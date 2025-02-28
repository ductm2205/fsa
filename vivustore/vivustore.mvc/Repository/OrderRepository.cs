using System;
using vivustore.mvc.Data;
using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public class OrderRepository(ViVuStoreDbContext context) : GenericRepository<Order>(context)
{
}
