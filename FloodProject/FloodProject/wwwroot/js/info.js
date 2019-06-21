

Hide_All_Sections = () => {
    $(".info-section").each(function (index) {
        $(this).hide();
    });
}; 

Show_Motivation_Section = () => {
    Hide_All_Sections(); 

    $('#motivation').show(); 
}; 

Show_Scope_Section = () => {
    Hide_All_Sections();

    $('#scope').show();
}; 

Show_Dotnetcore_Section = () => {
    Hide_All_Sections();

    $('#dotnetcore').show();
}; 

Show_Arcgis_Section = () => {
    Hide_All_Sections();

    $('#arcgis').show();
}; 

Show_Nationalflooddata_Section = () => {
    Hide_All_Sections();

    $('#nationalflooddata').show();
}; 

Show_Github_Section = () => {
    Hide_All_Sections();

    $('#github').show();
}; 

Show_Azure_Section = () => {
    Hide_All_Sections();

    $('#azure').show();
}; 