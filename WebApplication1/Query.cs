using HotChocolate.Types;

namespace WebApplication1
{
    public class Query
    {
        public Model GetModel() =>
            new()
            {
                Name = "Test Name",
                Value = "Test Value"
            };
    }

    public class Model
    {
        public string Value { get; set; }
        public string Name { get; set; }
    }

    public class ModelType : ObjectType<Model>
    {
        protected override void Configure(IObjectTypeDescriptor<Model> descriptor)
        {
            descriptor.Authorize();
            descriptor.Field(m => m.Name)
                .Authorize();
        }
    }
}