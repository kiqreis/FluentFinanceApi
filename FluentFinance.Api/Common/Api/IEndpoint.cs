namespace FluentFinance.Api.Common.Api;

public interface IEndpoint
{
  static abstract void Map(IEndpointRouteBuilder routeBuilder);
}