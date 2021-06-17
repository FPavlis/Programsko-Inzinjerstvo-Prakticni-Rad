Ovo je mapa vašeg programskog koda. U nju smjestite vaše rješenje (solution) i pripadajuće mape. Kod izrade rješenja **jako je važno** prije prvog uploada dokumenata postaviti i koristiti ispravan .gitignore. Za vas smo pripremili inicijalnu verziju .gitignore dokumenta koju po potrebi možete dopuniti i doraditi, a sukladno tehnologijama koje ćete koristiti. 

Uvijek uzmite u obzir da se ne verzioniraju dokumenti koje IDE kreira prilikom prevođenja ili pokretanja projekta. Također uzmite u obzir da dobro verzioniran programski kod zadovoljava dva uvjeta:
 - Nakon preuzimanja i kompajliranja programskog koda sa repozitorija, razvojno okruženje ne vraća nikakve pogreške
 - Nakon kompajliranja i pokretanja projekta, ako niste radili nikakve promjene na kodu, repozitorij ostaje čist i nije potrebno raditi novu verziju


Napomena za podešavanje instaliranja Windows Servica:
Prije pokretanja aplikacije potrebno je navesti direktorij gdje se nalazi Servis koji se želi instalirati. 
Znači što Vi trebate napraviti da kod Vas radi, kada bi buildali cijeli solution, je otići u FormWinService.cs klasu i u metodama button_click u liniju koda process.StartInfo.WorkingDirectory = @"C:\Users\kowas\Documents\pi21-skovacic2-fpavlis-iparac\Software\ObavijestiService\bin\Debug"; promjeniti ovaj direktorij u Vaš @"C:\Users\kowas\Documents\ Umjesto Users\kowas, što je moj direktorij Vi morate promjeniti u svoj i sve će raditi.