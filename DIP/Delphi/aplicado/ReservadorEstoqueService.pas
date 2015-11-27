unit ReservadorEstoqueService;

interface

type
  IReservadorEstoqueService = interface
    procedure ReservarEstoque(carrinho: TCarrinho);
  end;
  
  TReservadorEstoqueService = class(TInterfacedObject, IReservadorEstoqueService)
    public
      procedure ReservarEstoque(carrinho: TCarrinho);
  end;

implementation

procedure TReservadorEstoqueService.ReservarEstoque(carrinho: TCarrinho);
var 
	count: Integer;
	sistemaEstoque: TSistemaEstoque;
begin
	for count := 0 to (carrinho.Itens.Length - 1)  do
	begin
		sistemaEstoque := TSistemaEstoque.Create;
		sistemaEstoque.Reservar(item.Id, item.Quantidade);
	end
end

end.
