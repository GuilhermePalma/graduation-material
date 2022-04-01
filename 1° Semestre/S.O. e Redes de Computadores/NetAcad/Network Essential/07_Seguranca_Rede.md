# Capitulo 7: Segurança e Vulnerabilidades nas Redes

## Conteudo

> Aguardando Fim do Capitulo para Customização

--

## Resumo

> Aguardando Fim do Capitulo para Criação

---

### Formas de Ataques

- O acesso de pessoas mal intencionadas na rede pode trazer algumas consequencias ruins. Alguns dos Objetivos dessas pessoas são:
  - Roubo/Revenda de Informações
  - Alteração/Manipulação/Exclusão de Registros
  - Roubo de Identidade
  - Interrupção no Funcionamento do Sistema
- O acesso pode ser feito de 2 formas
  - Ameaças Externas: Uma pessoa de Fora tenta uma entrada forçada na empresa, utilizando da Internet, Links sem fio ou Servidores Dial-Up
  - Ameaças Internas: Se trata de ataques a partir de um funcionario da propria empresa, em que normalmente, conhece a politica interna e as informações confidenciais. Nem sempre é um ataque intencional, podendo ocorrer a partir de uma contaminação por um virus ou a ação de alguma ameaça de segurança

### Engenharia Social

- Ocorre quando uma pessoa utiliza de tecnicas para influenciar o comportamento da outra, executando comandos ou obtendo informações sensiveis.
-
#### Tecnicas da Engenharia Social

- Pretexting: Um cenario cenario é inventado utilizando informações reais do Usuario
- Phishing: O Invasr se passa por um empresa legitima, enviando emails ou mensagens solicitando a verificação de informações, como senhas e codigos de acesso, para que certas ações não aconteçam
- Vishing/Phishing por telefone: O Invasor deixa uma mensagem de voz se identificando como uma empresa legitima e solicita o retorno da Ligação. Quando o Usuario realiza o retorno, é solicitado e captados os dados usados no "login"


### Ataques no Software

- É possivel utilizar softwares que explore vulnerabilidade ou do não entendimento do usuario para executar ações mal-intesionadas. Alguns tipos são:
  - Virus: Podem ser encontrados em emails, downloads, ou em dispositivos USB. É necessario que o usuario inicie o Virus, após isso, ele pode tanto se replicar, como fazer ações mais danosas ao sistema, como corromper o HD
  - Worms: São semelhantes aos virus, porem conseguem ser executado de maneira independente e  se espalham pelos hosts da rede de forma rapida
  - Cavalo de Troia: Simulam um Software legitimo, mas diferentemente dos demais, não se replicam e tem como objetivo obter os acessos do computador ou danificar-lo

### Ataques de Sobrecarga

#### Ataque DoS

- O invasor buscam interromper ou afetar o funcionamento de um Software fazendo um sobrecarga de requisições. Normalmente isso pode ser feita de:
  - Imundação Sincrona: É enviado varios pacotes com endereços de IPs de Origem validos e o dispositivo acaba se sobrecarregando ao tentar lidar com cada requisição
  - Ping da Morte: Um pacote com o tamanho maior que o maximo (65.535 bytes) permitido por IP são enviados para o dispositivo. Por ser um pacote fora do padrão, o dispositivo pode travar ao tentar processar
- Os ataques podem focar em: um unico ou grupo de computadores, servidores, roteadors e links de rede
- Um ataque é plenajado pensando em:
  - Imundar o sitema ou rede para impedir o fluxo de outros dispositivos
  - Interromper conexões entre os clientes e servidorara impedir o acesso a um serviço
- Como utiliza de um unico endereço de IP é mais facil de isolar e se defender do ataque

#### Ataque DDoS

- É uma forma mais prejudicial, evoluida e em maior escala que o DoS, utilizada para sobrecarregar links de rede com dados desnecessarios.
- Normalmente utiliza de milhares de dispositivos para sobrecarregar um alvo no mesmo instante

#### Ataque de Força Bruta

- Força Bruta: Utiliza de um computador rapido que faza tentatias sucessivas em senhas ou descodificação da criptografia do site. Com isso, gera um trafego excessivo que reduz o desempenho de um recurso ou do software em si

### Coleta de Dados

- Tem como objetivo coletar informações para usar em anuncios, marketings, pesquisas. Não danificam o computador, mas invade a privacidade do Usuario

#### Spyware

- Normalmente são instalados ao baixar um arquivo ou clicando em um Pop-Up e são dificies de serem removidos. Ao coletarem as informações, é possivel obter as informações sensiveis (documentos, dados bancarios) tambem
- Podem reduzir o desempenho do computador, alterar configurações (o que acaba deixnao o computador vulneravel)

#### Rastreamento de Cookies

- São uma forma de Spyware que armazena informações sobre um usuario quando acesa um site
- Pode ser util quando se customiza/personaliza dados em sites
- Traçam as propagandas conforme as pesquisas realizadas pelo Usuario

> Continuar no Capitulo 7.2.2.2

---

[<--- Pagina Anterior **(Capitulo 6: Rede Domestica)**](06_Rede_Domestica.md)

[**Home**](README.MD)
