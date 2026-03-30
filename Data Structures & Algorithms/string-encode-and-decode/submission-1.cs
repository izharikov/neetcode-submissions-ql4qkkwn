public class Solution {
    const char Separator = (char) 256;
    public string Encode(IList<string> strs) {
        if (strs.Count == 0){
            return null;
        }
        return string.Join(Separator.ToString(), strs);
    }

    public List<string> Decode(string s) {
        if (s == null){
            return new List<string>();
        }
        return s.Split(new [] {Separator}).ToList();
   }
}
