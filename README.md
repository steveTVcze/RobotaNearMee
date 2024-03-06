# RobotaNearMe
Tento projekt je závěrečným projektem na předmět programování. Projekt jsou vlastně dvě aplikace - Api (RobotaNearMe) a klient (RobotaNearMe.Client) - Api je udělaná v ASP.NET a klient je dělán pomocí Blazoru ♥♥♥♥

Je ještě library RobotaNearMe.Lib - ale ta by měla být pro běžného uživatele, který neplánuje přidat další tabulky do databáze nebo upravovat endpointy nezajímavá.

Tato aplikace umožňuje registraci a login pouze přes Google, protože je to nejpřívětivější a nejrozšířenější možnost registrace.

## Postup instalace projektu
1) Naklonovat repositář
2) Spustit terminál ve složce RobotaNearMe - API
3) Do terminálu napsat: docker compose up -d
dotnet ef migrations add -nazev
dotnet ef database update
4) Do databáze zapsat tři role:
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/9535a2a6-3e48-40fd-91bb-df2bd475738e)
6) Zaregistrovat se za admina na API - na API je možnost pouze jednoho admina - jakmile je v databázi někdo registrovaný jako admin, nepůjde vám vytvořit nový admin účet.
7) Přidat JobFieldy jaké chcete - např. Developer atd.
8) V tento moment už by vše mělo fungovat bez problému - nyní se můžete registrovat na klientovi, vytvářet firmy, job offery prostě co jen chcete vyžadujete.

### Export dat do PDF a Excelu 
Všechny věci, kromě exportu PDF job offeru by se měly ukládat do Downloads. Nevím jak to funguje na Macu, ale na Windows by s tím neměl být žádný problém a nikde by se žádná cesta neměla upravovat.

## Diagram databáze
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/96889483-7b34-4a28-bcc1-8de688cea5a9)



## Návod
V této sekci bych se rád zaměřil na **základní obsluhu** mojí aplikace. Aplikace se vlastně dělí na dvě aplikace - API - ve které by měl mít možné změny provádět pouze někdo s Admin účtem a poté Client - kdokoli bude mít přístup k receptáři a fóru -> ve fóru bude moci postovat příspěvky a komentáře pouze jako Anynom - pro využití hlavní náplně aplikace, tedy jakéhosi vylepšeného deníčku je potřeba se zaregistrovat a potvrdit svůj mail.



### Client
##### Nepřihlášený uživatel
-stránka home - ("/") - využívá 3 externí API :D
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/b7c9ccde-5960-4367-a67b-fc904ffa3ce1)

#### Registrace
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/cd01f45d-8e89-414b-96bd-08a877b41603)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/89c9215b-648e-4757-83be-56ab9cb6c1f4)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/b649d968-f68d-4c1e-a282-983ee2e72141)

po kliknutí a potvrzení odkazu následuje možnost přihlášení

#### Přihlášení

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ec9fb9a5-6593-4ce0-9cd0-e9a10c467143)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/099e1db2-deca-40ca-be2f-f4b58b44f62c)
-home stránka

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ec48f400-fce6-49e2-aef9-b8ac2b3c8183)
- stránka profilu

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/76c03f98-63aa-4c94-9353-4ae96a6dd083)
- možnost úpravy profilu

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/60da0515-b9a6-464f-b890-c478c446e4e3)
- list job offerů

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/70743490-862a-4163-9b4b-354d0f5e2341)
- funkční filtrování(zabralo docela dost času :( )


![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/1f10cbec-72ac-4191-a66d-eb38c01c81d5)
- opět ukázka funkčního filtrování


![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/b8d1699a-1d8f-4e89-bc70-142988643fa8)
- opět ukázka funkčního filtrování

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/103c41d9-e559-43cc-b1bd-13468e178604)
- zobrazení job offeru

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/3c9e54bb-5441-4081-9a4e-2b47e818d3ee)
- možnost vytištění stránky

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/10a60db1-c5b6-442e-a09b-aa5719f5bbf6)
- sdílení na X.com - dříve Twitteru

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/46abbb71-1c2b-41b3-9d0f-a8fb005f02dc)
-ukládá se do složky s projektem

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/c8ac7e35-670d-4c2c-aae7-e05208088c35)
- odeslání job offeru na mail

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ca40cb96-d450-4ac4-8707-67ac5fa74799)
-po odpovězení na nabídku práce jste přesměrováni na home stránku a po opětovném navštívení stránky s danou nabídkou práce tlačítko pro odpověď na nabídku zmizí

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/da2b48f7-6666-4046-af1f-b72b48d8eaac)
- 

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/418f9c71-8323-43ca-80ba-f4d69db379c8)
- přidání firmy

#### Přihlášení za firmu - jako admin

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/bcaeca30-f57f-4b7e-8c7f-d33007bc2042)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/2521c674-8a63-4b3f-971d-1c3d780c9e86)
- home page, stejná jako u klienta a nepřihlášeného uživatele

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/5fa7e22f-38c5-4045-8abd-bf7b91d339af)
- přidání job offeru 

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/c7d549f3-cb8e-4284-a97e-84d33de9f2ab)
- list všech job offerů pro selectnutí které potom upravit

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/edc668b9-f6c7-49ca-81bd-f6009f4d7a35)
- úprava job offeru

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/66211e0a-10a3-44b3-aa5f-5c4780df65f2)
- stránka exportu uživatelů - list všech offerů vytvořených firmou 

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/a85ed455-61a0-4f14-8690-e0b1fb08c654)
- možnost stažení CVčka, exportu dat do Excelu, nebo do PDF

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/5202a2a1-5e6f-4b57-a5c1-09d62f202ff0)
- ukázka toho, že se CVčko opravdu stáhnulo

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/3db91323-826a-4b2c-86a3-8e4a0809cf94)
- ukázka toho, že se Excel opravdu stáhnul

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/01655fbe-c237-4470-bbba-cd14f725387b)
- ukázka toho, že se PDF opravdu stáhnulo

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/d5534e82-cdae-48a6-b3d8-d5dcbef749b8)
- ukázka stažení CVčka uživatele - měl jsem tam nahrané tohle PDF :D

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/428c327a-5df8-4433-a07f-52f0559859b0)
- ukázka exportu do Excelu
- 
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ff0ef858-cfb2-4d66-b523-bbd4184f1093)
- ukázka exportu do PDF

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/9b0dcdeb-0902-44c6-adad-04b64667f269)
- Možnost zobrazení profilu a následné tlačítka pro přesměrování na úpravu buďto profilu uživatele, nebo firmy. Důvod proč ten snímek vypadá tak špatně je, že jsem dal špatně screenshot a už se mi to nechce upravovat :D Jinak vypadá úplně normálně.

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/baa717c9-ccaf-4eb9-a7ee-ff3318549583)
- odeslání mailu někomu z userů kteří odpověděli na nabídku

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/0a96a966-1287-4a33-9251-707b9d64189a)
- ověření že to opravdu přišlo

### API
Tato aplikace slouží jednak pro správu admin funkcí, ale také jako API na kterou posílá requesty client, když chce něco z databáze
![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/ea07a23c-77d2-4c14-9fa8-2fa4b37d1a9f)

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/7f4c694e-2260-47a1-88c9-19a8be07dbc1)
-pokud se přihlásíte za účet se špatnou rolí, máte smůlu

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/85205958-e5b7-47e6-a173-5f1cedebeabb)
- možnost přidání jobFieldu

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/c46f9594-f382-4446-862f-6f27e0619098)
- ověření že se opravdu přidal

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/c81b8f06-8fe6-42ac-8775-54f4e6725295)
- možnost odeslání newsletteru všem uživatelům

![image](https://github.com/steveTVcze/RobotaNearMee/assets/72168369/5310e332-2279-4ebf-803a-cdef0a19351e)
- ověření že mail opravdu přišel

