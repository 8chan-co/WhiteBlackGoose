module Projects

type ProgrammingLanguage = CSharp | FSharp

type ProjectTile = {
    name : string
    url : string
    lang : ProgrammingLanguage
    date : string
}
    interface IDated

let projects = {
    { name = "CodegenAnalysis"; url = "https://github.com/WhiteBlackGoose/CodegenAnalysis"
    lang = CSharp; date = "2022-08-19" }
}