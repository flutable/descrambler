# descrambler
This small project descrambles text provided in a subject at Charles Sturt University.
1.	The file *Assi3_Task1_Scrambled.txt* was copied to the forensic VM. A copy was made (-copy appended).
2.	WinHex 17.52 was used to examine the file.
3.	The detected character set was CP 1252.


![](/images/FileAsOpened.png?raw=true "Optional Title")

4.	The entire contents were selected (Edit > Select All)
5.	The following operations were applied using the Edit > Modify Data.
6.	Right shift 7 bits (7 operations; no other shifts produced ASCII-only text)

![](/images/FileShiftRight7bits.png?raw=true "Optional Title")

7.	Shift left 1 byte to remove the initial 00

![](/images/FileShiftLeft1byte.png?raw=true "Optional Title")

8.	The text appears as reversed English words (where "word" is delimited by a space character).

```
gnoCutarital!snouoY vah us esecclufsu ylrcsnlbmab de stit ni sihelif fi  uoy nac eessihtalp t ni txe

):C

 emirecs  senovninivlid gatigem l aidgnarrf ef moduarsac t seoh oicim.sedeB  suacda ecnavt denhcegolo sei era woniavalbalo ,eo enht fom ec tsommorc nsemi si anifaicnrf l duacihwni hdulcsi eniusfo gkaf hc eskceam ,gnikts ,ilaea gns dnillef gn ekanediytitrac s sd hcud saevirl srnecia ecb dn knadrac  .siD

atigof lsner scicarpititrenoen sb dedaoru rerednnatsgnid fo  ehtesaceht ra yow enikrno g os yehtnac ran  worpocsfo eeht i risevnagitnoit

```
9.	Reversing the entire contents yields:

```
tiontiganvesir i thee ofscoprow  nar canthey so g onrkine woy ar thecasethe  of dingstannderer uroaded bs neonertitipracics rensl fogita

Dis.  cardank nd bce aicenrs lriveas duch ds s cartityidenake ng fellind sng aeali, stking, maeckse ch fakg ofsuine iscludh inwhicaud l frnciafina is imesn crommost ce mof thne oe, olablavainow are ies ologechned tvance adcaus  Bedes.micio hoes t casraudom fe frrangdia l megitag dilvininvones  scerime 

C:)

ext in t plathissee can you  if filehis in tits ed bamblnscrly usfulccese su hav Youons!latiratuCong
```
11.	Assume the first word is *Congratulations!*
We have:
![](/images/patterns.png?raw=true "Optional Title")
12.	The algorithm is to divide the ciphertext into 4-byte blocks, reverse each block, then concatenate the blocks.
13.	A custom application was written in C# to descramble the text. See Appendix 1 for source code. 
14.	Descrambling with block sizes of 2 and 3:

![](/images/blocksize23.png?raw=true "Optional Title")

15.	Finally, descrambling with a block size of 4 yields the correct answer:

![](/images/blocksize4.png?raw=true "Optional Title")


