libfiles = IRegularPolygon square
testfiles = testsquare

libsrc = $(addsuffix .cs, $(libfiles))
testsrc = $(addsuffix .cs, $(testfiles))
libs = $(addsuffix .dll, $(libfiles))
tests= $(addsuffix .exe, $(testfiles))

square_dep = IRegularPolygon

%.exe: %.cs
	@echo $@
	$(CC) -t:exe $(addprefix -r:, $(libs)) $<

%.dll: %.cs
	$(CC) -t:library -r:$($(basename $<)_dep) $<

linux: CC = mcs
windows: CC = csc

linux: $(libs) $(tests)
windows: $(libs) $(tests)
