A renderização estatica do lado do servidor ou Static Server Rendering(SSR)

Executa código no lado do servidor, como Razor Pages e MVC fazem.

A resposta completa é então enviada ao navegador para exibição ao visitante e não 
há mais interação entre o servidor e o cliente até que o navegador faça uma nova 
requisição HTTP.

Para que a renderização estática funcione, o mínimo necessário são duas chamadas 
para AddRazorComponents e MapRazorComponents<App>() configuradas na aplicação Blazor

Este é o modo padrão de renderização quando você não definir outro modo
