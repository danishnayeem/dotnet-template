namespace CoreLib.Models;
public class Api {
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  // Path in url
  public string Path { get; set; }
  public string Status { get; set; }
}

public class Group {
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  // Id from User table
  public int CreateBy { get; set; }
  public DateTime CreatedAt { get; set; }
  public string Status { get; set; }
}

public class GroupModule {
  public int Id { get; set; }
  public int GroupId { get; set; }
  public int ModuleId { get; set; }
  public string Status { get; set; }
}

public class GroupModuleSect {
  public int Id { get; set; }
  public int GroupId { get; set; }
  public int ModuleSectId { get; set; }
  public string Status { get; set; }
}

public class GroupRoute {
  public int Id { get; set; }
  public int GroupId { get; set; }
  public int RouteId { get; set; }
  public string Status { get; set; }
}

public class GroupRouteSect {
  public int Id { get; set; }
  public int GroupId { get; set; }
  public int RouteSectId { get; set; }
  public string Status { get; set; }
}

public class GroupSection {
  public int Id { get; set; }
  public int GroupId { get; set; }
  public int SectionId { get; set; }
  public string Status { get; set; }
}

public class Language {
  public int Id { get; set; }
  public string Code { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Status { get; set; }
}

public class LanguageKey {
  public int Id { get; set; }
  public string Key { get; set; }
  public string Description { get; set; }
  public string Status { get; set; }
}

public class LanguageKeyValue {
  public int Id { get; set; }
  public string Value { get; set; }
  public int LanguageId { get; set; }
  public int LanguageKeyId { get; set; }
}

public class Module {
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Url { get; set; }
  public string Icon { get; set; }
  public int Position { get; set; }
  // 0 means root module
  public int ParentId { get; set; }
  public string Status { get; set; }
}

public class ModuleSect {
  public int Id { get; set; }
  public int ModuleId { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Status { get; set; }
}

public class ModuleSectApi {
  public int Id { get; set; }
  public string Status { get; set; }
  public int ModuleSectId { get; set; }
  public int ApiId { get; set; }
}

public class Route {
  public int Id { get; set; }
  public int SectionId { get; set; }
  public int Position { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Url { get; set; }
  public string Icon { get; set; }
  public string Status { get; set; }
}

public class RouteSect {
  public int Id { get; set; }
  public int RouteId { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Status { get; set; }
}

public class RouteSectApi {
  public int Id { get; set; }
  public int PageSectId { get; set; }
  public int ApiId { get; set; }
  public string Status { get; set; }
}

public class Section {
  public int Id { get; set; }
  public int ModuleId { get; set; }
  public string Name { get; set; }
  public string Position { get; set; }
  public string Status { get; set; }
}

public class TableLanguage {
  public int Id { get; set; }
  public string TableName { get; set; }
  public int RowId { get; set; }
  public int LanguageId { get; set; }
  // Json object as Name, Description
  public string Value { get; set; }
  public string Status { get; set; }
}

public class User {
  public int Id { get; set; }
  // Id from Group table
  public int GroupId { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public string Phone { get; set; }
  public string LoginId { get; set; }
  public string LoginPassword { get; set; }
  // Id from User table
  public int CreatedBy { get; set; }
  public DateTime CreatedAt { get; set; }
  public string Status { get; set; }
}