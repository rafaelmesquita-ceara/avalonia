# Conversor de temperatura

Meu primeiro projeto utilizando a ferramenta AvaloniaUI, onde é possível converter a temperatura Celsius para Fahrenheit, vi conceitos básicos como: 
- Criar e rodar um projeto utilizando a IDE Rider, da JetBrains.
- Conceitos do componente Window, na qual modifiquei seus atributos para ter o tamanho 450x450 utilizando `Width="450" Height="450"` e definindo para a janela iniciar no centro da tela, com o atributo `WindowStartupLocation="CenterScreen"`
- Os componentes `<TextBlock>`, `<Button>`, `<StackPanel>`, `<Grid>`, `<TextBox>`, com seus respectivos atributos
- Eventos, utilizando o Button_OnClick, onde migrei posteriormente para utilizar o padrão MVVM

Após acompanhar o passo a passo da documentação https://docs.avaloniaui.net/docs/get-started/, modifiquei o código para adicionar algumas melhorias:
- Modifiquei o código para seguir o padrão MVVM, onde o `MainWindowViewModel` realiza toda a lógica da minha aplicação
- Inicialmente, o tutorial mostra dois TextBox e um Button, onde permite converter apenas de Celsius para Fahrenheit, e só calcula quando clica no botão, então modifiquei para que a conversão seja de mão dupla, e também faça isso em tempo real, com o evento sendo chamado ao modificar o valor de qualquer TextBox.
- Corrigi um problema que surgiu ao apagar todo o conteúdo do TextBox, onde o sistema não conseguia converter o conteúdo para double. Precisei criar uma classe conversora, chamada StringToDoubleConverter, onde é tratado o tipo primitivo vindo do TextBox, para retornar 0 caso o conteúdo esteja vazio.