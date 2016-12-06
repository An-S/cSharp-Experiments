space := $(shell printf " ")

#define string variable which contains only one " "

comma := ,

cflags = -nologo
alflags = -nologo
testdir = tests
libdir = libsrc
sharedir = share
cc = csc

tests = $(patsubst $(testdir)/%.cs, $(testdir)/%.exe, $(wildcard $(testdir)/*.cs))
modules = $(wildcard $(libdir)/*.cs) 
	#$(strip $(patsubst %.cs, %.module, $(wildcard $(libdir)/*.cs)))
shares = $(wildcard $(sharedir)/*.cs)
	#$(patsubst $(sharedir)/%.cs, $(sharedir)/%.module, $(wildcard $(sharedir)/*.cs))

$(testdir)/%.exe: $(testdir)/%.cs
	$(cc) $(cflags) /target:exe /reference:$(testdir)/dirstat.dll,$(testdir)/share.dll /out:$@ $<
	
$(libdir)/%.module: $(libdir)/%.cs
	$(cc) $(cflags) /target:module /reference:$(sharedir)/share.dll /out:$@ $<

$(sharedir)/%.module: $(sharedir)/%.cs
	$(cc) $(cflags) /target:module /out:$@ $<

$(testdir)/dirstat.dll: $(modules)
	$(cc) $(cflags) /target:library /reference:$(testdir)/share.dll /out:$@ $(modules)

$(testdir)/share.dll: $(shares)
	$(cc) $(cflags) /target:library /out:$@ $(shares)

all: $(testdir)/share.dll $(testdir)/dirstat.dll $(tests)

prVars:
	@echo $(modules)
	@echo $(tests)
	@echo $(patsubst %%,%$(comma)%,$(modules))