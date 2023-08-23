#Convert Extension Library

Karmaşık kod kümelerinde iç içe convert işlemleri ile değil, Builder Design Temelinde bir kullanım avantajı ve okunurluk sunmaktadır.

```csharp
	int value = 15;
	var result = value.AsString().AsInteger().AsLong();
	//Extension ile kullanamdan bu işlemi yaptığımızda ise şöyle bir yapı ortaya çıkmaktadır.
	var resultWithoutExtension = Convert.ToInt64(Convert.ToInt32(value.ToString()));
```
