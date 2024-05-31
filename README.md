# HotChocolate-GraphQL
Creating a GraphQL .NET server with Hot Chocolate

## What is GraphQL?
- One Endpoint
- One Request
- Type System
- Predictable
- Realtime

## Tips

### Deferred execution
- HotChocolate is designed to work seamlessly with `IQueryable` and supports **deferred execution** out of the box.
  - When you return an IQueryable from a resolver, HotChocolate will take care of executing the IQueryable.
  - ensure that the query is only executed once and only when needed. (_abstracted away from the developer_)

### Resolver dependency injection
- Create target service + inject it by resolver when needed to support multiple parallel operations
- Pooled dbContext for faster data fetching, retrieve one **DbContext** instance from the pool for each invocation of a **resolver**. Once the resolver has finished executing, the instance will be returned to the **pool**.

## Resources
- [Official documentation.](https://chillicream.com/docs/hotchocolate/v13)
- [Resolver injection of a DbContext.](https://chillicream.com/docs/hotchocolate/v13/integrations/entity-framework#resolver-injection-of-a-dbcontext)
- [DbContext pooling.](https://learn.microsoft.com/en-us/ef/core/performance/advanced-performance-topics?tabs=with-di%2Cexpression-api-with-constant#dbcontext-pooling)
- [GraphQL voyager.](https://github.com/graphql-kit/graphql-voyager)