using System;
using vivustore.mvc.Data;
using vivustore.mvc.Models;

namespace vivustore.mvc.Repository;

public class OrderDetailsRepository(ViVuStoreDbContext context) : GenericRepository<OrderDetails>(context)
{
}
