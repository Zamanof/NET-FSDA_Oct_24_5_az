/* 
                        S.O.L.I.D.

1. Single Responcibility Principle (SRP) - vahid mesuliyyrt prinsipi
    - There should never be more than one reason for a class to change.
    - Class-in deyishdirilmesi uchun yalniz bir sebeb olmalidir

2. Open-Closed Principle (OCP) - Achiq/qapali prinsipi
    - Software entities ... should be open for extension, but closed for modification
    - Proqramda olan "varliqlar" genishlenmeya achiq, deyishilmeye qapali olmalidir

3. Liskov Substitution Principle(LSP) - Liskov evezetme prinsipi
    - Functions that use pointers or references to base classes 
        must be able to use objects of derived classes without knowing it
    - Baza tipin istifade etdiyi funksionalliqlari, alttiplerimiz xeberdar olmasalar da
        bele istifade ede bilmelidir

4. Interface Segregation Principle(ISP) - interface-lerin ayrilmasi prinsipi
    - Clients should not be forced to depend upon interfaces that they do not use.
    - Mushteri istifade etmediyi interfaceden asili olmali deyil

5. Dependency Inversion Principle(DIP) - asililiqlarin inversiyasi prinsipi
    - States to depend upon abstractions, [not] concretes.
    - Asililiq abstraksiyadan asili olmalidir, Nedense konkret asili olmali deyil.

    - Yuxari seviyyeli modullar ve ashaqi seviyyeli modullar bir birinden 
        asili olmali deyil. Her ikisi abstraksiyadan asili olmalidir.
    - Abstraksiya detallardan asili olmali deyil. Detallar abstraksiyadan asili olmalidir.
*/
