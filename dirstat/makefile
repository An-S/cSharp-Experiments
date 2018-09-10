space := $(shell printf " ")

#define string variable which contains only one " "

comma := ,

cflags = -nologo
alflags = -nologo
testdir = tests
libdir = libsrc
utestdir = tests
sharedir = share
libincdir = C:/Users/MyAcer/Documents/Programmieren/UnitTesting/NUnit/net-4.5/

libs = nunit.framework.dll nunit.framework.tests.dll nunit.testdata.dll nunitlite.dll slow-nunit-tests.dll

cc = csc

utests = $(patsubst $(utestdir)/%.cs, $(testdir)/%.dll, $(wildcard $(utestdir)/utest*.cs))
tests = $(patsubst $(testdir)/%.cs, $(testdir)/%.exe, $(filter-out $(wildcard $(utestdir)/utest*.cs), $(wildcard $(testdir)/*.cs)))
modules = $(wildcard $(libdir)/*.cs) 
	#$(strip $(patsubst %.cs, %.module, $(wildcard $(libdir)/*.cs)))
shares = $(wildcard $(sharedir)/*.cs)
	#$(patsubst $(sharedir)/%.cs, $(sharedir)/%.module, $(wildcard $(sharedir)/*.cs))

$(testdir)/%.dll: $(testdir)/%.cs
	$(cc) $(cflags) /target:library /reference:$(testdir)/dirstat.dll,$(testdir)/share.dll $(addprefix /reference:$(libincdir), $(libs)) /out:$@ $<

$(testdir)/%.exe: $(testdir)/%.cs
	$(cc) $(cflags) /target:exe /reference:$(testdir)/dirstat.dll,$(testdir)/share.dll  /out:$@ $<	

$(libdir)/%.module: $(libdir)/%.cs
	$(cc) $(cflags) /target:module /reference:$(sharedir)/share.dll /out:$@ $<

$(sharedir)/%.module: $(sharedir)/%.cs
	$(cc) $(cflags) /target:module /out:$@ $<

$(testdir)/dirstat.dll: $(modules)
	$(cc) $(cflags) /target:library /reference:$(testdir)/share.dll /out:$@ $(modules)

$(testdir)/share.dll: $(shares)
	$(cc) $(cflags) /target:library /out:$@ $(shares)

all: $(testdir)/share.dll $(testdir)/dirstat.dll $(tests) $(utests)

prVars:
	@echo "Modules: " $(modules)
	@echo "Tests: " $(tests)
	@echo "Unit tests: " $(utests)
	@echo $(patsubst %%,%$(comma)%,$(modules))