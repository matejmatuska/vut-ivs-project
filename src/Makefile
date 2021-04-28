ROOT_DIR=..
DOC_DIR=docs
INSTALLER_DIR=Setup\Release
INSTALLER_NAME=Setup_JMMM_Calculator.msi

BUILD_DIRS=Calculator\bin Calculator\obj Tests\bin Tests\obj Stdev\bin Stdev\obj Setup\Debug packages
TMP_PACK_DIR=..\..\pack
PACK_NAME=xmatus36_xmazak02_xpokor85_xschaf00.zip

.PHONY: all pack clean run profile help

all: run

pack:
	if exist $(TMP_PACK_DIR) del $(TMP_PACK_DIR) /s /f /q 1>nul & rmdir $(TMP_PACK_DIR) /s /q
	mkdir $(TMP_PACK_DIR)

	mkdir $(TMP_PACK_DIR)\doc
	xcopy /s $(DOC_DIR)\html $(TMP_PACK_DIR)\doc

	mkdir $(TMP_PACK_DIR)\install
	xcopy /s $(INSTALLER_DIR)\$(INSTALLER_NAME) $(TMP_PACK_DIR)\install

	mkdir $(TMP_PACK_DIR)\repo
	xcopy /s $(ROOT_DIR) $(TMP_PACK_DIR)\repo

	cd $(TMP_PACK_DIR) && tar.exe -c -f ..\$(PACK_NAME) .

	del $(TMP_PACK_DIR) /s /f /q 1>nul & rmdir $(TMP_PACK_DIR) /s /q

clean:
	for %%d in ($(BUILD_DIRS)) do ( del %%d /s /f /q 1>nul & rmdir %%d /s /q)
	del IVS-Calculator.sln.DotSettings.user

# the project must be compiled in Visual Studio or Rider
run: 
	Calculator\bin\Debug\IVS-Calculator.exe

# the project must be compiled in Visual Studio or Rider
profile: 
	Stdev\bin\Debug\Stdev.exe < Stdev\randomnumbers1000.txt

# (vypíše nápovědu s popisem, co je potřeba udělat před spuštěním programu)
help:
	@echo make should be started from the src
	@echo Before running targets run or profile please make sure to build the corresponding targets first in Visual Studio
	@echo Before running target pack please make sure to build the installer first in Visual Studio