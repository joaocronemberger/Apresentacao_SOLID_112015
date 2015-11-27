interface ICalculadorRegra
{
	bool PodeCalcular(string medida);
	decimal Calcular(ItemCarrinho item);
}

class CalculadorRegraUnidade : ICalculadorRegra
{
	bool PodeCalcular(string medida)
	{
		return medida == "unidade";
	}
		
	decimal Calcular(ItemCarrinho item)
	{
		return item.Quantidade * 5;
	}
}

class CalculadorRegraPeso : ICalculadorRegra
{
	bool PodeCalcular(string medida)
	{
		return medida == "peso";
	}
		
	decimal Calcular(ItemCarrinho item)
	{
		return item.Quantidade * 4 / 1000;
	}
}

class CalculadorRegraEspecial : ICalculadorRegra
{
	bool PodeCalcular(string medida)
	{
		return medida == "especial";
	}
		
	decimal Calcular(ItemCarrinho item)
	{
		var total = item.Quantidade * 0.4;
  		var pacoteDeTres = item.Quantidade / 3;
  		return total - pacoteDeTres * 0.2;
	}
}