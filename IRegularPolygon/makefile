libfiles = IRegularPolygon square
testfiles = testsquare

libsrc = $(addsuffix .cs, $(libfiles))
testsrc = $(addsuffix .cs, $(testfiles))
libs = $(addsuffix .dll, $(libfiles))
tests= $(addsuffix .exe, $(testfiles))

%.exe: %.cs
	$(CC) -t:exe -r:$(libs) $<

%.dll: %.cs
	$(CC) -t:library $<

linux: CC = gcm
windows: CC = csc

linux: $(libs) $(tests)
windows: $(libs) $(tests)
