try{
	$translationsLocation = "C:\Solita.LocalizationEditor.Translations"
	md $translationsLocation

	Write-Host "Installation done" -ForegroundColor green
}
catch{
	Write-Host $_.Exception.Message -ForegroundColor Red
}
