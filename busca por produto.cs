using  System ;
usando o  sistema . Coleções . Genérico ;
usando  Mono . Dados . Sqlite ;


class  MainClass {

   
  public  static  void  Cadastrar () {
 
    Console . WriteLine ( " \ n \ n Cadastro de Produto " );
    Console . Write ( " Nome: " );
    string  nome  =  Console . ReadLine ();
    Console . Write ( " Preço: " );
    double  preco  =  converter . ToDouble ( Console . ReadLine ());
    Produto  p  =  novo  Produto ( nome , preco );
    p . Persistir ();

  }

  public  static  void  Listar ()
  {
    Console . WriteLine ( " \ n " );
    Lista < Produto > produtos  =  Produto . ConsultarProdutos ();
    foreach ( var  produto  em  produtos )
    {
      produto . Imprimir ();
    }
    Console . WriteLine ( " ====================== " );
    Console . WriteLine ( " Digite qualquer tecla para volta " );
    Console . WriteLine ( " ====================== " );
  }


  public  static  void  Procurar ()
  {  
    Console . Limpar ();
    Console . WriteLine ( " ====================== " );
    Console . WriteLine ( " Digite o nome do produto de que deseja procurar " );
    Console . WriteLine ( " ====================== " );

    string  procurar_  =  Console . ReadLine ();
 
    Console . Limpar ();
    Console . WriteLine ( " ====================== " );
    Console . WriteLine ( " Mostrando todos os registros de: {0} " , procurar_ );
    Console . WriteLine ( " ====================== " );
  
    Lista < Produto > produtos  =  Produto . ProcurarProdutos ( procurar_ );
    foreach ( var  produto  em  produtos )
    {
      produto . Imprimir ();
    }
  
    Console . WriteLine ( " ====================== " );
    Console . WriteLine ( " Digite qualquer tecla para volta " );
    Console . WriteLine ( " ====================== " );
  }
 

 
    public  static  void  Main ( string [] args )
          {                 
                bool  MostrarMenu  =  true ;
                enquanto ( MostrarMenu )
                {
                    MostrarMenu  =  MenuPrincipal ();
                }
          }


