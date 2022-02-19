## Maquinas Virtuais

As maquinas virtuais se tratam de Sistemas Operacionais sendo executados dentro de um Servidor ou dentro de outro Sistema Operacional

### Divisões da Maquina  Virtual
Host --> O Sistema da Maquina Virtual
Guest --> O sistema sendo executado na Maquina Virtual
Kernel --> Parte que faz a ligção entre os Softwares e o processamento no Hardware

### HyperVision (Monitor da Maquina Virtual)
O Hypervision é o monitor da Maquina Virtual. Por meio dele é possivel criar e rodar as Maquinas Vitruais. O HyperVisiona possui 2 tipos:
- Tipo 1 (Bare Metal)
  - Software: VMware
  - Preferivel, mais otimizada
  - Locação Direta de Memoria --> Define uma Memoria Fixa para cada aplicação

- Tipo 2: 
  - Software: Virtual Machine
  - Karnel: S.O que faz o gerenciamento do hardware 
  - Varias aplicações rodam em conjuto --> Não há o alocamento de memoria
    - Aplicações que demandam mais memoria, 'rouba' a memoria dos demais

### Tipos de Servidores

|nome|Limite Usuarios|Limite VM|
|----------|---------|---------|
|Essentials|    2    |    ?    |
|  Stander |Ilimitado|    2    |
|Essentials|Ilimitado|Ilimitado|