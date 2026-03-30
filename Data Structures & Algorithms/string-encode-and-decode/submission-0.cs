public class Solution {
    const char Separator = (char) 256;
    public string Encode(IList<string> strs) {
        return string.Join(Separator.ToString(), strs);
    }

    public List<string> Decode(string s) {
        return s.Split(new [] {Separator}).ToList();
   }
}
