# Dokumentacija o radu

Nakon što sam pročitao zadatke, odlučio sam da ću raditi zadatak pomoću MVC okvira.
Za temu rada sam odabrao shopping listu. 

## Funkcionalnost aplikacije

Aplikacija treba omogučiti održavanje shopping liste.
Shopping lista se sastoji od shopping itema (proizvode koje treba kupiti).
U shopping listu se mogu dodavati novi shopping itemi, uređivati postojeći te brisati.
Svaki shopping item sastoji se od imena i opisa.

## Implementacija

### Modeli
Imam ShoppingItem model koji služi za predstavljanje shopping itema

### Kontroleri
Imam HomeController koji je zadužen za naslovnu stranicu i ShoppingItemsController koji je zadužen za održavanje shopping liste.

### Views

#### Home
- Index
- Privacy

#### ShoppingItems
- Create
- Delete
- Details
- Edit
- Index

## Baza
SQL server: baza koristi SQL server
Tablice su napravljene pomoću code first pristupa te postoje migracijske datoteke 
- shopinglistaContextModelSnapshot.cs