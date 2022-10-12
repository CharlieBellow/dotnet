# App Séries LGBTQIA em .NET

Essa foi minha primeira tentativa de fazer um projeto.

Minha ideia foi criar um app de séries LGBTQIA+ pois pertenço a essa comunidade - me identifico como homem trans-, e isso me fez gotar ainda mai de construir esse projeto. Acredito que esse projeto seja relevante pois muitas pessoas desconhecem o universo da comunidade LGBTQIA+ e por isso tendem a julgar sem conhecer. Esse projeto, além de mostrar minha habilidades em .NET, traz informação pra comunidade Dev. Espero que gostem!

## O que aprendi?

Como é meu primeiro projeto, aprendi um pouco mais sobre como funciona essas estruturas de classe, me familiarizei com a linguagem C#. Entendi a importância de separar os códigos em arquivos distintos e como referenciá-los nos arquivos principais. Aprendi a importância de saber escrever o código usando os paretros corretos para que as informações não se percam, e de uma forma que garanta que apenas as ações que desejamos sejam executadas, sem alterar outra parte indesejada do código.

### Erro persistente que foi resolvido

#### Erro 1

Trata-se de um erro na linha 115 do Program.cs

<!-- Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido?"*Excluído*" : ""));
essa linha teve que ser comentada, pois com ela, o programa não rodava. o erro encontrado era: 
App de séries/Series-LGBTQIA/Program.cs(115,100): error CS0266: Não é possível converter implicitamente tipo "object" em "bool". Existe uma conversão explícita (há uma conversão ausente?)
Como tive que comentar essa linha, o programa só deixa cadastrar séries e não pode listar  -->

Era um erro rque ocorria por conte de ausencia de código na parte de métodos do arquivo Serie.cs

### Erro 2

por alguma razão, ao listar as séries todos os IDs são mostrados com o índice zero.

#### Obs

Segui o tutorial do Bootcamp da Take Blip na DIO. Lá eles ensinam tudo no Ru-windows, mas eu utilizo linux. A versão do .Net do professor era diferente da minha, pelo que li o modelo using system não era necessário, mas pode ter havido algum erro de compatibilidade entre versões. Se alguém puder/quiser me ajudar a resolver esses problemas e, principalmente queria me ensinar como resolve e pq está errado, ficarei muito agradecido!
OBS2: Essa área de desenvlvimento é muito desafiadora e nova pra mim. Estou fazendo transição de carreira, venho da área da Psicologia onde acabei de terminar meu mestrado. Estou aqui aprendendo sobre programação por conta própria e levo minha paixão pela tecnologia e meu gosto pelos estudos como fontes de inspiração pra continuar aprendendo!
