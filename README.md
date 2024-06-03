# Festas Infantis

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

---
## Descri��o

Rafaela possui um neg�cio de festas infantis. Ela precisa controlar os alugu�is e para isso ela precisa de uma aplica��o que permita cadastrar clientes, temas, itens de festa e alugu�is.

## Funcionalidades

1. O cadastro do **Cliente** consiste de:
	- nome
	- telefone
	- cpf
	- alugu�is*

	1.1. Deve ser poss�vel calcular um **desconto** para novos alugu�is a partir de algu�is concluidos.
    1.2. Dever� ser poss�vel visualizar os alugu�is relacionados a um cliente atrav�s de um bot�o na tela principal.

2. O cadastro do **Tema** consiste de:
	- nome
	- valor (total)
	- itens
	- alugu�is*

	2.1. Deve ser poss�vel incluir v�rios itens em um tema, somando o valor total com base no valor de cada item.

3. O cadastro do **Item** consiste de:
	- descri��o
	- valor
	- tema

	3.1. N�o deve ser poss�vel utilizar o mesmo item em temas diferentes.

4. O cadastro do **Aluguel** consiste de:
	- cliente
	- tema
	- porcentagem de entrada
	- porcentagem de desconto
	- data do pagamento (caso concl�ido)
	- status
	- festa

	4.1. A porcentagem de entrada � obrigat�ria e dever� ser selecionada entre os valores 40% e 50%.
	

    4.2. O cadastro da **Festa** ser� realizado durante o aluguel e consiste de:
		- endere�o
		- data
		- hora de in�cio
		- hora de t�rmino
    
    4.3. Dever� ser possivel filtrar a tabela de alugu�is entre alugu�is pendentes e conclu�dos. 
	
    4.4. Dever� ser poss�vel concluir um aluguel atrav�s de um bot�o na tela principal.
1. 
5. O **Controle de Desconto** consiste de:
	- porcentagem de desconto por aluguel
	- porcentagem m�xima de desconto

	5.1. Para cada aluguel realizado por um cliente (a partir do primeiro), dever� ser calculado um valor de desconto.
    5.2. O valor dever� ser calculado pela f�rmula: (quantidade de alugu�is do cliente * porcentagem de desconto).
	5.3. As porcentagens dever�o ser configuradas � partir de um bot�o da tela principal.
---

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
git clone https://github.com/academia-do-programador/festas-infantis-2024.git
```

#### Navegue at� a pasta raiz da solu��o
```
cd festas-infantis-2024
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd FestasInfantis.WinApp
```

#### Execute o projeto
```
dotnet run
```