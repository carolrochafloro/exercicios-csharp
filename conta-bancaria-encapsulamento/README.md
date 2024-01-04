# Exercício - criação e operações em conta bancária

## Enunciado
Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do 
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito 
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua 
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.  

Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já 
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por 
exemplo).  

Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger 
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque 
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
suficiente para realizar o saque e/ou pagar a taxa.  

Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre 
mostrando os dados da conta após cada operação.  

## Soluções
### Classe - Conta
#### :moneybag: Atributos:

- Número: Identificador único da conta.
- Nome do Titular: Nome do proprietário da conta.
- Saldo: Valor monetário disponível na conta.

#### :no_entry_sign: Restrições e Propriedades:

- O número da conta não pode ser alterado após a criação, tendo a propriedade *private set*.
- O nome do titular pode ser modificado a qualquer momento.
- O saldo inicial é 0 e só pode ser alterado por meio das operações de saque ou depósito, possuindo a propriedade *private set*.

#### :building_construction: Construtores:

- O primeiro construtor exige o número da conta e o nome do titular como parâmetros obrigatórios, inicializando o saldo com 0.
- O segundo construtor, além dos parâmetros mencionados, permite a inclusão de um depósito inicial no momento da criação da conta.
Funções.

#### :1234: Tipo de Dado do Número da Conta:

Embora o exercício indique o número da conta como int, a escolha foi armazená-lo como string para permitir que contas com o primeiro dígito 0 sejam corretamente registradas. Para isso, foi implementada uma função que verifica se todos os caracteres informados são números.

#### :repeat: Menu Recursivo: 

Implementação de um menu recursivo para a execução das operações de saque e depósito, incluindo a validação do caractere digitado para garantir a correta interação com o usuário.
