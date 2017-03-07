LIBSRC= $(wildcard Parse/*.cs) $(wildcard Print/*.cs) $(wildcard Tokens/*.cs)
LIB =   SPP.netmodule
SRC =   Scheme4101.cs $(wildcard Tree/*.cs) $(wildcard Special/*.cs)
EXE =   Scheme4101.exe

all: $(EXE)

$(EXE): $(SRC) $(LIB)
	mcs /out:$(EXE) $(SRC) /addmodule:$(LIB)

$(LIB): $(LIBSRC)
	mcs /target:module /out:$(LIB) $(LIBSRC)

clean:
	@rm -f *~ */*~

veryclean:
	@rm -f $(EXE) *~ */*~
