// Exemplo para ValidacoesListaTests
public class ValidacoesListaTests
{
    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var validacoesLista = new ValidacoesLista();
        var lista = new List<int> { -2, 5, -10, 8, -3 };

        // Act
        var resultado = validacoesLista.RemoverNumerosNegativos(lista);

        // Assert
        Assert.All(resultado, numero => Assert.True(numero >= 0));
    }
}









