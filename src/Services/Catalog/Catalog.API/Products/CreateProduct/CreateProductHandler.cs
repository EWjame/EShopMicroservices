using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    
    public record CreateProductCommand(string Name,List<string> Catagory, string Description,string ImageFile, decimal Price) :IRequest<CreateProductResult>;

    public record CreateProductResult(Guid Id);

    internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
            public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                
            }
    }
}