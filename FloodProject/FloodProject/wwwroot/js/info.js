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

Show_Tools_Section = () => {
    Hide_All_Sections();

    $('#tools').show();
}; 