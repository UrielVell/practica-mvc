namespace practica06;

public interface IDataContext{
    public Task<List<Producto>> ObtenerProductosAsync();
}